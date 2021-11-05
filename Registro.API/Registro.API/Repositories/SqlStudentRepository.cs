﻿using System;
using Registro.API.DataModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Registro.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext context;
        public SqlStudentRepository(StudentAdminContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }

    }
}