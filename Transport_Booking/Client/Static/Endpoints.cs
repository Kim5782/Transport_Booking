namespace Transport_Booking.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string VehiclesEndpoint = $"{Prefix}/vehicles";
        public static readonly string FeedbacksEndpoint = $"{Prefix}/feedbacks";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
        public static readonly string TransportBookingsEndpoint = $"{Prefix}/transportbookings";
    }
}
