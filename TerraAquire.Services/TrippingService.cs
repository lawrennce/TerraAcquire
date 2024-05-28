using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerraAquire.Contracts.TrippingCustomers;
using TerraAquire.Contracts;
using TerraAquire.Data;
using TerraAquire.Services.Common;
using TerraAquire.Contracts.Trippings;

namespace TerraAquire.Services
{
    public class TrippingService : BaseService, ITrippingService
    {
        private readonly IRepository<Tripping> _trippingRepository;
        public TrippingService(IConfiguration configuration, ILogger<BaseService> logger, IMapper mapper,
              IRepository<Tripping> trippingRepository
        )
            : base(configuration, logger, mapper)
        {
            _trippingRepository = trippingRepository;
        }

        //public async Task<OperationDto<SchoolPostDto>>? Create(CreateDto? dto)
        //{
        //    try
        //    {
        //        if (dto == null)
        //        {
        //            return new OperationDto<SchoolPostDto>()
        //            {
        //                Status = OpStatus.Fail,
        //                Message = "dto is null"
        //            };
        //        }

        //        var schoolPost = new SchoolPost()
        //        {
        //            Id = dto!.Id != null ? dto.Id : Guid.NewGuid(),
        //            Content = dto!.Content,
        //            Title = dto!.Title,
        //            CreatedAt = DateTime.Now,
        //            UpdatedAt = DateTime.Now,
        //            UserId = dto!.UserId,
        //            IsActive = true
        //        };

        //        await _schoolPostRepository.AddAsync(schoolPost);

        //        var thumbnailSchoolPostMedium = new SchoolPostMedium()
        //        {
        //            Id = Guid.NewGuid(),
        //            SchoolPostId = schoolPost.Id,
        //            CreatedAt = DateTime.Now,
        //            UpdatedAt = DateTime.Now,
        //            MediaType = Data.Enums.MediaType.Thumbnail,
        //            Value = $"/schoolposts/{schoolPost.Id}/thumbnail.png"
        //        };

        //        var galleryImageSchoolPostMedium = new SchoolPostMedium()
        //        {
        //            Id = Guid.NewGuid(),
        //            SchoolPostId = schoolPost.Id,
        //            CreatedAt = DateTime.Now,
        //            UpdatedAt = DateTime.Now,
        //            MediaType = Data.Enums.MediaType.GalleryImage,
        //            Value = $"/schoolposts/{schoolPost.Id}/gallery-image.png"
        //        };

        //        var articleImageSchoolPostMedium = new SchoolPostMedium()
        //        {
        //            Id = Guid.NewGuid(),
        //            SchoolPostId = schoolPost.Id,
        //            CreatedAt = DateTime.Now,
        //            UpdatedAt = DateTime.Now,
        //            MediaType = Data.Enums.MediaType.ArticleImage,
        //            Value = $"/schoolposts/{schoolPost.Id}/article-image.png"
        //        };

        //        await _schoolPostMediumRepository.AddAsync(thumbnailSchoolPostMedium);
        //        await _schoolPostMediumRepository.AddAsync(galleryImageSchoolPostMedium);
        //        await _schoolPostMediumRepository.AddAsync(articleImageSchoolPostMedium);

        //        await _schoolPostRepository.SaveChangesAsync();

        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            ReferenceId = schoolPost.Id,
        //            ReferenceData = Mapper.Map<SchoolPostDto>(schoolPost),
        //            Status = OpStatus.Ok,
        //            Message = "Success"
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            Status = OpStatus.Fail,
        //            Message = ex.Message
        //        };
        //    }
        //}

        //public async Task<OperationDto<SchoolPostDto>>? Update(UpdateDto? dto)
        //{
        //    try
        //    {
        //        if (dto == null)
        //        {
        //            return new OperationDto<SchoolPostDto>()
        //            {
        //                Status = OpStatus.Fail,
        //                Message = "dto is null"
        //            };
        //        }

        //        var schoolPost = _schoolPostRepository.All().FirstOrDefault(a => a.Id == dto.Id);

        //        if (schoolPost != null)
        //        {
        //            schoolPost.Content = dto!.Content;
        //            schoolPost.Title = dto!.Title;
        //            schoolPost.UpdatedAt = DateTime.Now;

        //            _schoolPostRepository.Update(schoolPost);
        //        }

        //        await _schoolPostRepository.SaveChangesAsync();

        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            ReferenceId = schoolPost.Id,
        //            ReferenceData = Mapper.Map<SchoolPostDto>(schoolPost),
        //            Status = OpStatus.Ok,
        //            Message = "Success"
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            Status = OpStatus.Fail,
        //            Message = ex.Message
        //        };
        //    }
        //}

        //public async Task<OperationDto<SchoolPostDto>>? Delete(ActivationDto? dto)
        //{
        //    try
        //    {
        //        if (dto == null)
        //        {
        //            return new OperationDto<SchoolPostDto>()
        //            {
        //                Status = OpStatus.Fail,
        //                Message = "dto is null"
        //            };
        //        }

        //        var schoolPost = _schoolPostRepository.All().FirstOrDefault(a => a.Id == dto.Id);

        //        if (schoolPost != null)
        //        {
        //            schoolPost.IsActive = false;
        //            schoolPost.UpdatedAt = DateTime.Now;

        //            _schoolPostRepository.Update(schoolPost);
        //        }

        //        await _schoolPostRepository.SaveChangesAsync();

        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            ReferenceId = schoolPost.Id,
        //            ReferenceData = Mapper.Map<SchoolPostDto>(schoolPost),
        //            Status = OpStatus.Ok,
        //            Message = "Success"
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            Status = OpStatus.Fail,
        //            Message = ex.Message
        //        };
        //    }
        //}

        //public async Task<OperationDto<SchoolPostDto>>? Restore(ActivationDto? dto)
        //{
        //    try
        //    {
        //        if (dto == null)
        //        {
        //            return new OperationDto<SchoolPostDto>()
        //            {
        //                Status = OpStatus.Fail,
        //                Message = "dto is null"
        //            };
        //        }

        //        var schoolPost = _schoolPostRepository.All().FirstOrDefault(a => a.Id == dto.Id);

        //        if (schoolPost != null)
        //        {
        //            schoolPost.IsActive = true;
        //            schoolPost.UpdatedAt = DateTime.Now;

        //            _schoolPostRepository.Update(schoolPost);
        //        }

        //        await _schoolPostRepository.SaveChangesAsync();

        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            ReferenceId = schoolPost.Id,
        //            ReferenceData = Mapper.Map<SchoolPostDto>(schoolPost),
        //            Status = OpStatus.Ok,
        //            Message = "Success"
        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new OperationDto<SchoolPostDto>()
        //        {
        //            Status = OpStatus.Fail,
        //            Message = ex.Message
        //        };
        //    }
        //}

        //public SchoolPostDto? GetSchoolPostById(Guid? id)
        //{
        //    var query = _schoolPostRepository.All()
        //                 .Include(a => a.User)
        //                 .FirstOrDefault(a => a.Id == id);

        //    var result = Mapper.Map<SchoolPostDto>(query);

        //    var media = _schoolPostMediumRepository.All().Where(a => a.SchoolPostId == id).ToList();

        //    result.SchoolPostMedia = media;

        //    return result;
        //}

        public async Task<Paged<TrippingDto>>? Search(bool? isActive = true, int? pageIndex = 1, int? pageSize = 10, string? keyword = "")
        {
            var query = _trippingRepository.All().AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query =  _trippingRepository.All()
                            .Where(a => a.Agent!.FullName != null && a.Agent.FullName.ToLower().Contains(keyword.ToLower()));
            }

            var count = query.Count();
            var skip = ((pageIndex - 1) * pageSize)!.Value;
            var list = query.Skip(skip).Take(pageSize!.Value).ToList();
            
            var result = Mapper.Map<List<TrippingDto>>(list);

            return new Paged<TrippingDto>()
            {
                PageIndex = pageIndex.Value,
                PageSize = pageSize.Value,
                Items = result,
                TotalItems = count,
                IsActive = isActive,
            };
        }
    }
}
