﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController:ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CelestialObjectController(ApplicationDbContext _context)
        {
            context = _context;
        }
    }
}
