using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;

namespace CleanArchitecture.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(viewModel => new CreateCourseCommand(viewModel.Name, viewModel.Description, viewModel.ImageUrl));
        }
    }
}
