﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerce.Shared.ResponseDTOs
{
    public class ResponseDTO<T>
    {
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }  // Özelliğin adı 'Errors' olarak değiştirildi

        [JsonIgnore]
        public bool IsSucceeded { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        // Geriye veri döndüren başarılı cevap
        public static ResponseDTO<T> Success(T data, int statusCode)
        {
            return new ResponseDTO<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        // Geriye veri döndürmeyen başarılı cevap
        public static ResponseDTO<T> Success(int statusCode)
        {
            return new ResponseDTO<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }

        // Tek hata döndüren başarısız cevap
        public static ResponseDTO<T> Fail(string error, int statusCode)
        {
            return new ResponseDTO<T>
            {
                Errors = new List<string> { error },  // 'Error' yerine 'Errors' kullanıldı
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }

        // Birden fazla hata döndüren cevap
        public static ResponseDTO<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDTO<T>
            {
                Errors = errors,  // 'Error' yerine 'Errors' kullanıldı
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }
    }
}
