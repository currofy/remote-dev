namespace UserBlazor.Data
{
    #region using
    using System.Threading.Tasks;
    using UserServices;
    using Grpc.Net.Client;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Grpc.Core;
    using System.Net.Http;
    #endregion

    public class UserWebServices
    {
        #region Global Vars
        private string gUserServicesUrl = "https://backend.default:5001";
        //private string gUserServicesUrl = "https://localhost:5001/";
        //private string gUserServicesUrl = "http://127.0.0.1:50051";
        #endregion

        public Task<UserWeb[]> GetUsersAsync()
        {
            //GrpcChannelOptions vChannelOpt = new GrpcChannelOptions();
            //vChannelOpt.Credentials = ChannelCredentials.Insecure;

            var vHttpClientHandler = new HttpClientHandler();
            vHttpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var vHttpClient = new HttpClient(vHttpClientHandler);

            var vChannel = GrpcChannel.ForAddress(gUserServicesUrl, new GrpcChannelOptions { HttpClient = vHttpClient });
            var vClient = new UserRepo.UserRepoClient(vChannel);

            var vUsers = vClient.GetAll(new Nothing());

            var vUserWeb = vUsers.Records.AsEnumerable().Select(vUserRecord => new UserWeb
            {
                UserId = vUserRecord.UserId,
                UserName = vUserRecord.UserName,
                UserEmail = vUserRecord.UserEMail
            }).ToArray();

            return Task.FromResult(vUserWeb);
        }

        public Task<bool> AddUserWeb(UserWeb pUserWeb)
        {
            var vHttpClientHandler = new HttpClientHandler();
            vHttpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var vHttpClient = new HttpClient(vHttpClientHandler);

            var vChannel = GrpcChannel.ForAddress(gUserServicesUrl, new GrpcChannelOptions { HttpClient = vHttpClient });
            var vClient = new UserRepo.UserRepoClient(vChannel);

            Nothing vInsertUser = vClient.Add(new UserServices.User()
            {
                UserName = pUserWeb.UserName,
                UserEMail = pUserWeb.UserEmail
            });

            return Task.FromResult(true);
        }

        public Task<UserWeb> GetById(int pUserId)
        {
            var vHttpClientHandler = new HttpClientHandler();
            vHttpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var vHttpClient = new HttpClient(vHttpClientHandler);

            var vChannel = GrpcChannel.ForAddress(gUserServicesUrl, new GrpcChannelOptions { HttpClient = vHttpClient });
            var vClient = new UserRepo.UserRepoClient(vChannel);

            var vGetUser = vClient.GetById(new UserFilter() { UserId = pUserId });

            UserWeb vUserResult = new UserWeb()
            {
                UserId = vGetUser.UserId,
                UserName = vGetUser.UserName,
                UserEmail = vGetUser.UserEMail
            };

            return Task.FromResult(vUserResult);
        }

        public Task<bool> Update(UserWeb pUserWeb)
        {
            var vHttpClientHandler = new HttpClientHandler();
            vHttpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var vHttpClient = new HttpClient(vHttpClientHandler);

            var vChannel = GrpcChannel.ForAddress(gUserServicesUrl, new GrpcChannelOptions { HttpClient = vHttpClient });
            var vClient = new UserRepo.UserRepoClient(vChannel);

            User vUpdateUser = new User()
            {
                UserId = pUserWeb.UserId,
                UserName = pUserWeb.UserName,
                UserEMail = pUserWeb.UserEmail
            };

            vClient.Update(vUpdateUser);

            return Task.FromResult(true);
        }

        public Task<bool> Delete(int pUserId)
        {
            var vHttpClientHandler = new HttpClientHandler();
            vHttpClientHandler.ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;
            var vHttpClient = new HttpClient(vHttpClientHandler);

            var vChannel = GrpcChannel.ForAddress(gUserServicesUrl, new GrpcChannelOptions { HttpClient = vHttpClient });
            var vClient = new UserRepo.UserRepoClient(vChannel);

            vClient.Delete(new UserFilter() { UserId = pUserId });

            return Task.FromResult(true);
        }
    }
}
