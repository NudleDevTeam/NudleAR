namespace ND.AR.Project.API.Authorazation
{
    public class JWTAuthourazation
    {
        private readonly RequestDelegate _next;
        
        public JWTAuthourazation(RequestDelegate next)
        {
            _next = next;
        }

         public async Task Invoke(HttpContext context)
        {
            if (!context.Request.Path.ToString().StartsWith("/swagger/index.html"))
                {
                context.Response.Redirect("/swagger/index.html");
                }
            else
            {
                await _next(context);
            }
        }
    }
}
