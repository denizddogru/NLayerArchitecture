﻿using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;

namespace NLayer.API.Controllers;


public class CustomBaseController : ControllerBase
{
    // Bu bir endpoint değil, kendi içimde bu metodu kullanıyourm.
    [NonAction]
    public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
    {
        if (response.StatusCode == 204)
            return new ObjectResult(null)
            {
                StatusCode = response.StatusCode
            };
        return new ObjectResult(response) {  StatusCode = response.StatusCode };
    }
}