using System.Collections.Generic;
using Ordering.Components;

namespace Ordering.Services
{
    public interface ISurveyService
    {
        List<SurveyProduct> GetSurveyProducts();       
        void IncreaseVoteCount(int productId);
    }
}