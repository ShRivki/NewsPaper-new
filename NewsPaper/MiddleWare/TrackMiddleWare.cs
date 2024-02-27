namespace ManagingANewspaper.MiddleWare
{
    public class TrackMiddleWare
    {
        private readonly RequestDelegate _next;

        public TrackMiddleWare(RequestDelegate applicationBuilder)
        {
            _next = applicationBuilder;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var requestSeq = Guid.NewGuid().ToString();
            context.Items.Add("RequestSequence", requestSeq);
            if (DateTime.Now.Hour > 5 )
            {
                await _next(context);
            }
            else
            {
                throw new InvalidOperationException("it's too late!  go to sleep"+ DateTime.Now.Hour);
            }
        }
    }
    public static class TrackMiddlewareExtensions
    {
        public static IApplicationBuilder UseTrack(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TrackMiddleWare>();
        }
    }

}
