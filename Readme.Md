Route(Yönlendirme) Nedir?

Gelen istekleri(request) URL'leriyle eşleştirerek sayfa isteği işlemeyi sağlar. Rotayı belirlemek için kullanılan şablondur.
.Net Core'da varsayılan yönlendirme endpoint routing olarak isimlendirilir.
Program.cs'te varsayılan olarak aşağıdaki gibi tanımlanır:

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

Not: Yönlendirme, UseRouting ve UseEndpoints Middleware(ara yazılım) kullanılarak yapılandırılır.

UseRouting ve UseEndpoint Middleware yapısı

Kullanıcı istekte bulunduğunda hangi controller için çalışacağını, hangi action'ı ilgili model ile çalıştırıp response döneceğini program.cs class'ı içerisindeki UseRouting() Middleware yapısı gerçekleştirir. UseEndpoint Middleware sayesinde ise gelen isteğin hangi controller ve hangi action'a yönlendirilmesi gerektiğini belirleyebiliriz.
{controller=Home}/{action=Index}/{id?} patterni kullandığımızda default'ta bir rota belirlemiş oluruz.