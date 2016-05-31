using System;
using System.Collections.Generic;
using System.Linq;
using Chasoliveira.Core.Dto;
using Chasoliveira.Core.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Chasoliveira.Core.Application
{
    public static class DbInitializer
    {

        private static IPersonAppService _personAppService;
        public static void Initialize(IServiceProvider serviceProvider)
        {
            _personAppService = (IPersonAppService)serviceProvider.GetService(typeof(IPersonAppService));
            var context = (Data.Contexts.ChasoDBContext)serviceProvider.GetService(typeof(Data.Contexts.ChasoDBContext));
            context.Database.Migrate();
            InitializePerson();
        }

        private static void InitializePerson()
        {
            if (_personAppService.All().Any()) return;
            var person = new PersonDTO
            {
                FirstName = "Charles",
                MiddleName = "Silva",
                LastName = "Oliveira",
                Birthday = new DateTime(1986, 06, 01),
                Occupation = "Systems Analyst - .Net Developer",
                PhotoProfile = "images/chasoliveira.jpg",
                PersonStatment = "Sou Engenheiro de Software, com duas especializações a mais recente em Governança de TI e a anterior em Engenharia de Sistemas, "+
                "sou Bacharel em Sistemas de Informação, atualmente trabalho em um projecto com Xamarin, consumindo Web API Restfull, "+
                "tenho experiência em ASP.NET MVC, Visual C #, .NET , já fiz alguns trabalhos com Visual Basic .NET e outros com PHP. Tenho tido oportunidade de desenvolver com utilizando banco de dados "+
                "SQL Server, mas eu já usei Firebird, MySQL e PostgreSQL, eu gosto de estudar novas tecnologias, criar produtos inovadores, eu gosto de resolver problemas e desenvolver soluções seguindo normas e técnicas recomendadas pela comunidade.",
                Contacts = new List<ContactDTO> {
                    new ContactDTO { Ord=1,Icon = "home", Description = "chasoliveira.com.br", Url = "/"},
                    new ContactDTO
                    {
                         Ord=2,
                        Icon = "envelope-o",
                        Description = "charles@chasoliveira.com.br",
                        Url = "mailto:charles@chasoliveira.com.br"
                    },
                    new ContactDTO { Ord=2, Icon = "phone", Description = "+55 (94) 98112-9774", Url = ""},
                    new ContactDTO { Ord=3, Icon = "skype", Description = "chasoliveira", Url = "skype:chasoliveira?call"}
                },
                Skills = new List<SkillDTO> {
                    new SkillDTO { Ord=1, Class="success",  Description = "C#", Progress = 90.0m },
                    new SkillDTO { Ord=2, Class="info", Description = "ASP.NET MVC", Progress = 85.0m },
                    new SkillDTO { Ord=3, Class="warning", Description = "MS SQL", Progress = 80.0m },
                    new SkillDTO { Ord=4, Class="danger", Description = "JavaScript", Progress = 70.0m },
                    new SkillDTO { Ord=5, Class="info", Description = "AngularJS", Progress = 30.0m },
                },
                Socials = new List<SocialDTO> {
                    new SocialDTO { Ord=1, Icon = "linkedin", Url = "https://linkedin.com/in/chasoliveira", Description = "LinkedIn"},
                    new SocialDTO { Ord=2, Icon = "github", Url = "https://github.com/chasoliveira",Description = "GitHub"},
                    new SocialDTO { Ord=3, Icon = "rss", Url = "https://blog.chasoliveira.com.br", Description = "Blogger"},
                    new SocialDTO { Ord=4, Icon = "facebook", Url = "http://facebook.com.br/chasoliveira", Description = "Facebook"},
                    new SocialDTO { Ord=5, Icon = "google-plus", Url = "https://plus.google.com/u/0/+CharlesSilvaOliveira",Description = "Google Plus"},
                    new SocialDTO { Ord=6, Icon = "twitter", Url = "http://twitter.com/chasoliveira", Description = "Twitter"},
                    new SocialDTO { Ord=7, Icon = "instagram", Url = "http://instagram.com/chasoliveira",Description = "Instagram"},
                },
                Histories = new List<HistoryDTO> {
                     new HistoryDTO
                    {
                        Ord =1,
                        HistoryType = HistoryType.Education,
                        Title = "Governança de TI",
                        Company = "Centro Universitário Leonardo da Vinci - UNIASSELVI",
                        Location = "Online",
                        Description = "",
                        Start = new DateTime(2014, 11, 10),
                        Finished = new DateTime(2016,03,24)
                    },
                    new HistoryDTO
                    {
                        Ord =2,
                        HistoryType = HistoryType.Education,
                        Title = "Engenharia de Sistemas",
                        Company = "Escola Superior Aberta do Brasil - ESAB",
                        Location = "Marabá-PA, Brazil",
                        Description = "",
                        Start = new DateTime(2013, 07, 01),
                        Finished = new DateTime(2014, 06, 10)
                    },
                    new HistoryDTO
                    {
                        Ord =3,
                        HistoryType = HistoryType.Education,
                        Title = "Bacharel em Sistemas de Informação",
                        Company = "Centro de Ensino Superior de Marabá - CEMAR",
                        Location = "Marabá-PA, Brazil",
                        Description = "",
                        Start = new DateTime(2007, 07, 01),
                        Finished = new DateTime(2011, 07, 30)
                    },
                    new HistoryDTO
                    {
                          Ord =3,
                        HistoryType = HistoryType.Position,
                        Title = "Software Engineer - .Net Developer",
                        Company = "M2S Software",
                        Location = "Recife-PE, Brazil",
                        Description =
                            "Atuo na análise e desenvolvimento de aplicativos cross-plataforma em Xamarin com a liguagem C#, também como parte do mesmo projeto, faço parte do time que desenvolve a versão web em ASP.Net MVC e Web API. Na camada de abstração de acesso a dados utilizaçãos o ORM NHibernate.",
                        Start = new DateTime(2016, 01, 05),
                        Finished = null
                    },
                    new HistoryDTO
                    {
                        Ord =5,
                        HistoryType = HistoryType.Position,
                        Title = "Analista de Sistemas - .Net Developer",
                        Company = "SINOBRAS - Siderúrgica Norte Brasil S.A",
                        Location = "Marabá-PA, Brazil",
                        Description =
                            "Fui responsável por análisar e desenvolver aplicativos web, desktop e microservices, implementando as melhores práticas de desenvolvimento juntamente com o uso de padrões de projetos na plataforma ASP.NET MVC. Sendo o banco de dados Microsoft SQL Server, abstraído pela ferramenta de mapeamento de objetos relacionais Entity Framework, para persistência de dados. ",
                        Start = new DateTime(2014, 07, 01),
                        Finished = new DateTime(2016,01,04)
                    },
                    new HistoryDTO
                    {
                        Ord =6,
                        HistoryType = HistoryType.Position,
                        Title = "Sócio Diretor - Analista de Sistemas",
                        Company = "Carajás TI & Telecom",
                        Location = "Marabá-PA, Brazil",
                        Description =
                            "Além da dirigir a empresa, minha atividade preferida era o desenvolvimento de softwares, Gestão de Conteúdo Empresarial - Digitalização e Gerenciamento Eletrônico de Documentos.",
                        Start = new DateTime(2011, 09, 01),
                        Finished = new DateTime(2014, 06, 18)
                    },
                    new HistoryDTO
                    {
                        Ord =7,
                        HistoryType = HistoryType.Position,
                        Title = "Gerente de TI",
                        Company = "Laboratório Biotest",
                        Location = "Marabá-PA, Brazil",
                        Description =
                            "Gerenciamento do Departamento de TI, Instalação e Suporte do Sistema Madya, além do desenvolvimento de pequenos aplicativos de apoio ao sistema Madya (MadyaMonitor, MadyaProced, MadyaLWS, etc..). Desenvolvimento do Biofidelity (Sistema de Fidelização Aplicado ao Laboratório de Análises Clínicas Biotest).",
                        Start = new DateTime(2007, 06, 01),
                        Finished = new DateTime(2011, 09, 01)
                    },
                    new HistoryDTO
                    {
                        Ord =8,
                        HistoryType = HistoryType.Position,
                        Title = "Assessor Técnico",
                        Company = "Biomédica Distribuidora",
                        Location = "Marabá-PA, Brazil",
                        Description =
                            "Gerente de Departamento de Tecnologia da Informação - Atuando como técnico em montagem e manutenção de computadores e redes, Implantação, treinamento e gerenciamento de Sistema de Informação Laboratorial Madya (www.feedline.com.br), desenvolvimento do software (INFOS - Sistema de Gerenciamento de Assistência Técnica).",
                        Start = new DateTime(2007, 07, 01),
                        Finished = new DateTime(2011, 07, 30)
                    }
                },
                Users = new List<UserDTO> { new UserDTO { Active = true, Password = "cso010686", UserName = "chasoliveira" } }
            };
            _personAppService.Add(person);
            _personAppService.SaveChanges();
        }
    }
}
