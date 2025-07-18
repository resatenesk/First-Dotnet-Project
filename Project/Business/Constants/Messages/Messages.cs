using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAddedMessage = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string CarListed = "Araçlar listelendi";
        public static string CustomerAddedMessage = "Müşteri eklendi";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = " Kullanıcı bulunamadı";
        public static string PasswordError = "Parola yanlış";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Giriş tokeni oluşturuldu";
    }
}