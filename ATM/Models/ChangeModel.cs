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
}