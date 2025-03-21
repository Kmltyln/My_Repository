using System;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Shared.Helpers;

public class CustomControllerBase:ControllerBase
{
public static IActionResult CreateActionResult<T>(ResponseDto<T>responseDto)
{
    return new ObjectResult(responseDto)
    {
        StatusCode=responseDto.StatusCode,
    };
}
}
