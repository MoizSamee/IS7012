using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSameemz.Pages.Models;

namespace RecruitCatSameemz.Data
{
    public class RecruitCatSameemzContext : DbContext
    {
        public RecruitCatSameemzContext (DbContextOptions<RecruitCatSameemzContext> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSameemz.Pages.Models.Company> Company { get; set; }
    }
}
