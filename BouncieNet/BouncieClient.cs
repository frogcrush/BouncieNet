using BouncieNet.Models;
using Microsoft.Extensions.Logging;
using Refit;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BouncieNet
{
    public interface IBouncieClient
    {
        [Get("/v1/user")]
        Task<ApiResponse<BouncieUser>> GetUser();

        [Get("/v1/vehicles")]
        Task<ApiResponse<List<Vehicle>>> GetVehicles([Query] GetVehiclesRequestParameters parameters);

        [Get("/v1/trips")]
        Task<ApiResponse<List<Trip>>> GetTrips([Query] GetTripsRequestParameters parameters);
    }

    public class GetVehiclesRequestParameters
    {
        [AliasAs("imei")]
        public string? Imei { get; set; }

        [AliasAs("limit")]
        public int? Limit { get; set; }

        [AliasAs("skip")]
        public int? Skip { get; set; }

        [AliasAs("vin")]
        public string? Vin { get; set; }
    }

    public class GetTripsRequestParameters
    {
        [AliasAs("ends-before")]
        public DateTime? EndsBefore { get; set; }

        [AliasAs("gps-format")]
        public GpsFormatEnum? GpsFormat { get; set; }

        [AliasAs("imei")]
        public string? Imei { get; set; }

        [AliasAs("starts-after")]
        public DateTime? StartsAfter { get; set; }

        [AliasAs("transaction-id")]
        public string? TransactionId { get; set; }
    }

    public enum GpsFormatEnum
    {
        [EnumMember(Value = "polyline")]
        Polyline,

        [EnumMember(Value = "geojson")]
        GeoJson
    }
}