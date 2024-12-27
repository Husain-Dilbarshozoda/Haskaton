using System.Net;

namespace Domain.Responses;

public class Response<T>
{
    public T? Data { get; set; }
    public int HttpStatusCode { get; set; }
    public string Messeng { get; set; }


    public Response(T data)
    {
        Data = data;
        HttpStatusCode = 200;
        Messeng = "";
    }

    public Response(HttpStatusCode statusCode, string messeng)
    {
        HttpStatusCode = (int)statusCode;
        Messeng = messeng;
    }
    
    
    
}