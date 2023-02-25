using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace gRPCPublisher.SyncDataServices;

public class GrpcUserService : UserService.UserServiceBase
{
    public override Task<GetUserListResponse> GetUserList(GetUserListRequest request, ServerCallContext context)
    {
        var newUsers = new List<User>
        {
            new() {UserId = 1,Name = "Ömer Furkan", Surname = "Doğruyol", BirthDate = new DateTime(1996,05,19)},
            new() {UserId = 2,Name = "Selim", Surname = "Sever", BirthDate= new DateTime(1958,08,06)}
        };
        var userListResponseData = new List<GetUserListModel>();
        foreach (var item in newUsers)
        {
            userListResponseData.Add(new()
            {
                BirthDate = Timestamp.FromDateTimeOffset(item.BirthDate),
                UserId = item.UserId,
                Name = item.Name,
                Surname = item.Surname
            });
        }

        var userListResponse = new GetUserListResponse();
        userListResponse.UserList.AddRange(userListResponseData);
        return Task.FromResult(userListResponse);
    }
}
