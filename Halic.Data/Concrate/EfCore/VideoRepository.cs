﻿using Halic.Data.Abstract;
using Halic.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Halic.Data.Concrate.EfCore
{
    public class VideoRepository: GenericRepository<Video,HalicContext>,IVideoRepository
    {
    }
}
