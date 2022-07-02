﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.DataAccess.Data
{
    public class BlazorContext:DbContext
    {
        public BlazorContext(DbContextOptions<BlazorContext> options):base(options)
        {

        }
    }
}
