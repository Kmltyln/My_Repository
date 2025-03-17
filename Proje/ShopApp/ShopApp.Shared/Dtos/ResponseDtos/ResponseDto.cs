using System;

namespace ShopApp.Shared.Dtos.ResponseDtos
{
    public class ResponseDto<T> 
    {
    public T Data{get;set;}
    public string Error{get;set;}
    public int StatusCode{get;set;}
    public bool IsSucceeded{get;set;}
    public static ResponseDto<T>Success(T data,int statuscode)
    {
        return new ResponseDto<T>
        {
            Data=default(T),
            StatusCode=statuscode,
            IsSucceeded=true
        };
    }
    }

} 