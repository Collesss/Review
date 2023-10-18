using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Review.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            /*
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opts =>
                {
                    opts.RequireHttpsMetadata = true;
                    //opts.SaveToken = true;

                    opts.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = "Test",
                        ValidateAudience = true,
                        ValidAudience = "Test",
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Test_ghsdbgsdfbvgdfbv15123623534")),
                        ValidTypes = new[] { "access" }
                    };
                });

            builder.Services.AddAuthentication($"{JwtBearerDefaults.AuthenticationScheme}1")
                .AddJwtBearer(opts =>
                {
                    opts.RequireHttpsMetadata = true;
                    //opts.SaveToken = true;

                    opts.TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidIssuer = "Test",
                        ValidateAudience = true,
                        ValidAudience = "Test",
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Test_ghsdbgsdfbvgdfbv15123623534")),
                        ValidTypes = new[] { "refresh" }
                    };
                });
            */
            /*
            builder.Services.AddAuthorization(conf => 
            {
                conf.AddPolicy("RefreshTokenPolicy", confP => 
                {
                    confP.AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                });
            });
            */

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}