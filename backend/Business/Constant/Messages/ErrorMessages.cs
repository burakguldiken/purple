using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant.Messages
{
    public static class ErrorMessages
    {
        public static readonly string Unauthorized = "Bu İşlem İçin Yetkiniz Bulunmamaktadır";

        public static readonly string UserNotFound = "Kullanıcı Bulunamadı";
        public static readonly string PassError = "Şifre Hatalı";
        public static readonly string UserAlreadyExists = "Bu Email Adresi Başka Bir Kullanıcı Tarafından Kullanılmakta";
        public static readonly string RegisterError = "Kayıt İşlemi Başarısız Oldu";
        public static readonly string TokenCreateError = "Token Oluşturulamadı";
    }
}
