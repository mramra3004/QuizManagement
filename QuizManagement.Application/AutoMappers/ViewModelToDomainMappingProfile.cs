using System;
using AutoMapper;
using QuizManagement.Application.Chapters.ViewModel;
using QuizManagement.Application.Exams.ViewModel;
using QuizManagement.Application.Permissions.ViewModel;
using QuizManagement.Application.Questions.ViewModel;
using QuizManagement.Application.Subjects.ViewModel;
using QuizManagement.Application.Users.ViewModel;
using QuizManagement.Data.Entities.Quiz;
using QuizManagement.Data.Entities.System;

namespace QuizManagement.Application.AutoMappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ChapterViewModel, Chapter>().ConstructUsing(c => new Chapter());
            CreateMap<SubjectViewModel, Subject>().ConstructUsing(c => new Subject());
            CreateMap<PermissionViewModel, Permission>().ConstructUsing(c => new Permission());
            CreateMap<QuestionViewModel, Question>().ConstructUsing(c => new Question());
            CreateMap<QuestionExamDetailViewModel, QuestionExamDetail>().ConstructUsing(c => new QuestionExamDetail());
            CreateMap<ExamViewModel, Exam>().ConstructUsing(c => new Exam());

            CreateMap<AppUserViewModel, AppUser>()
                .ConstructUsing(c => new AppUser(c.Id.GetValueOrDefault(Guid.Empty), c.FullName, c.UserName,
                    c.Email, c.PhoneNumber, c.Avatar, c.Status, c.BirthDay, c.Gender));
        }
    }
}