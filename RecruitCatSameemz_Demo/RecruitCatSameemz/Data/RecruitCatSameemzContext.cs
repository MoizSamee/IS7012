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

        public DbSet<RecruitCatSameemz.Pages.Models.Address> Address { get; set; }

        public DbSet<RecruitCatSameemz.Pages.Models.Candidate> Candidate { get; set; }

        public DbSet<RecruitCatSameemz.Pages.Models.Industry> Industry { get; set; }

        public DbSet<RecruitCatSameemz.Pages.Models.JobTitle> JobTitle { get; set; }
    }
}
