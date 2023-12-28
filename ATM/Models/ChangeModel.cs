namespace ATM.Models;

public static class ChangeModel
{
    public static AtmCardModel? Change(this AtmCardRequestModel? requestModel)
    {
        if (requestModel == null) return null;
        return new AtmCardModel
        {
            CardNo = requestModel.CardNo,
            Amount = requestModel.Amount
        };
    }

    public static UserModel? ChangeUser(this AtmCardRequestModel? requestModel)
    {
        if (requestModel == null) return null;
        return new UserModel
        {
            Name = requestModel.Name,
            Email = requestModel.Email,
            Password = requestModel.Password,
        };
    }
}