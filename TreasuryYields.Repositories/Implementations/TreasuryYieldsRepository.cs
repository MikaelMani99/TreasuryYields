using System;
using System.Globalization;
using System.Linq;
using TreasuryYields.Models.Entities;
using TreasuryYields.Repositories.Contexts.Interfaces;
using TreasuryYields.Repositories.Interfaces;
using TreasuryYields.Models.Exceptions;

namespace TreasuryYields.Repositories.Implementations
{
    public class TreasuryYieldsRepository : ITreasuryYieldsRepository
    {
        private readonly ITreasuryYieldsDbContext _dbContext;

        public TreasuryYieldsRepository(ITreasuryYieldsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TreasuryYieldsDay GetTreasuryYieldsDay(Guid ID)
        {
            return _dbContext.TreasuryYieldsDays.FirstOrDefault(d => d.ID == ID);
        }

        public TreasuryYieldsDay GetTreasuryYieldsDayByDate(String date, String format)
        {
            var dateFormatted = DateTime.ParseExact(
                date,
                format,
                CultureInfo.InvariantCulture
            );
            var yieldDay = _dbContext.TreasuryYieldsDays.FirstOrDefault(d => d.Date == dateFormatted);
            if (yieldDay == null) { throw new NotFoundException("no yield this day!"); }
            return yieldDay;
        }
    }
}