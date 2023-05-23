using Microsoft.EntityFrameworkCore;
using pointer_poc_minimal_api.Data;

namespace pointer_poc_minimal_api.Endpoints.Pointer
{
    public static class GetPointerAddressesEndpoint
    {
        private const string BuildingStatus = "BUILT";
        private const string AddressStatus = "APPROVED";
        private const int MaxPostCodeLength = 7;
        public static IEndpointRouteBuilder MapGetPointerAddressesEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("GetAddressByPostcode", async (string postCode, PointerContext context, CancellationToken cancellationToken) =>
            {
                var pointerModel = await context.Pointer.AsNoTracking().Where(i => i.Postcode == FormatPostCode(postCode) && i.BuildingStatus == BuildingStatus && i.AddressStatus == AddressStatus).OrderBy(i => i.BuildingNumber).ToListAsync(cancellationToken: cancellationToken);

                if (pointerModel.Count == 0)
                {
                    return Results.NotFound("Addresses not found");
                }

                return TypedResults.Ok(pointerModel);
            }).RequireAuthorization();

            app.MapGet("GetByBuildingNumberPostCode", async (string postCode, string buildingNumber, PointerContext context, CancellationToken cancellationToken) =>
            {
                var pointerModel = await context.Pointer.AsNoTracking().FirstOrDefaultAsync(i => i.Postcode == FormatPostCode(postCode) && i.BuildingNumber == buildingNumber.ToUpper() && i.BuildingStatus == BuildingStatus && i.AddressStatus == AddressStatus, cancellationToken: cancellationToken);

                if (pointerModel == null)
                {
                    return Results.NotFound("Address not found");
                }

                return TypedResults.Ok(pointerModel);
            }).RequireAuthorization();

            return app;
        }

        private static string FormatPostCode(string postcode)
        {
            string formattedPostcode = postcode.Replace("-", "").Replace(" ", "").ToUpper();

            switch (formattedPostcode.Length)
            {
                case 6:
                    formattedPostcode = formattedPostcode.Insert(3, " ");
                    break;
                case MaxPostCodeLength:
                    formattedPostcode = formattedPostcode.Insert(4, " ");
                    break;
            }

            return formattedPostcode;
        }
    }
}