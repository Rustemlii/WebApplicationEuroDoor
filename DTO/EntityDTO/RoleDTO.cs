﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.EntityDTO
{
    public class RoleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserDTO> Users { get; set; }
    }
}
