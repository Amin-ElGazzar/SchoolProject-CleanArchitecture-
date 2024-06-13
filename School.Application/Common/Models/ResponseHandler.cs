using Microsoft.Extensions.Localization;
using School.Application.SharedResources;

namespace School.Application.Common.Models
{
    public class ResponseHandler
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public ResponseHandler(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }
        public Response<T> Created<T>()
        {
            return new Response<T>
            {

                Succeeded = true,
                Message = _localizer[ResourceKey.Created],
                StatusCode = System.Net.HttpStatusCode.Created,

            };
        }

        public Response<T> Success<T>(T entity)
        {
            return new Response<T>
            {
                Data = entity,
                Succeeded = true,
                Message = _localizer[ResourceKey.Success],
                StatusCode = System.Net.HttpStatusCode.OK,

            };
        }

        public Response<T> NotFound<T>()
        {
            return new Response<T>
            {
                Succeeded = false,
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Message = _localizer[ResourceKey.NotFound]
            };
        }

        public Response<T> EditSuccess<T>()
        {
            return new Response<T>
            {
                Succeeded = true,
                Message = _localizer[ResourceKey.Edited],
                StatusCode = System.Net.HttpStatusCode.OK,

            };
        }

        public Response<T> Deleted<T>()
        {
            return new Response<T>
            {
                Succeeded = true,
                Message = "Deleted",
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }


    }
}
