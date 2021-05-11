using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant.Messages
{
    public static class ErrorMessages
    {
        public static string Unauthorized = "Bu İşlem İçin Yetkiniz Bulunmamaktadır";

        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string UserAlreadyExists = "Bu Email Adresi Başka Bir Kullanıcı Tarafından Kullanılmakta";
        public static string RegisterError = "Kayıt İşlemi Başarısız Oldu";
        public static string TokenCreateError = "Token Oluşturulamadı";
    }
}
