using FlashCards.UseCases.Entities;
using FlashCards.UseCases.Interfaces;
using FlashCards.UseCases.ValueObjects;

namespace FlashCards.MemoryRepository
{
    public class MemoryRepository : IQuestRepository
    {
        readonly List<ExamQuest> ExamQuests = new List<ExamQuest>
            {
                new ExamQuest
                {
                    Code = "YELLOW",
                    Name = "Kyu 10",
                    Subjects = new List<Subject>
                    {
                        new Subject
                        {
                            Name = "UKEMIS",
                            Quests = new List<Quest>
                            {
                                new Quest("Que son los UKEMIS", "Es la practica de las caidas")
                            },
                            Subjects = new List<Subject>
                            {
                                new Subject
                                {
                                    Name = "MAE",
                                    Quests = new List<Quest>
                                    {
                                        new Quest("En que direccion se ejecuta", "Es una caida en plancha hacia delante")
                                    }
                                },
                                new Subject
                                {
                                    Name = "Usiro",
                                    Quests = new List<Quest>
                                    {
                                        new Quest("En que direccion se ejecuta", "Es una caida hacia detras")
                                    }
                                },
                                new Subject
                                {
                                    Name = "Mawari",
                                    Quests = new List<Quest>
                                    {
                                        new Quest("En que direccion se ejecuta", "Es una caida rodando")
                                    },
                                    Subjects = new List<Subject>
                                    {
                                        new Subject
                                        {
                                            Name = "MAE",
                                            Quests= new List<Quest>
                                            {
                                                new Quest("En que direccion se ejecuta", "Es una caida en rodando hacia delante")
                                            }
                                        }
                                    }
                                }
                            }
                        },

                        new Subject
                        {
                            Name = "WAZA",
                            Quests = new List<Quest>
                            {
                                new Quest("Que es", "La definicion de las tecnicas. Projecciones, inmobilizaciones, luxaciones o estrangulaziones")
                            },
                            Subjects = new List<Subject>
                            {
                                new Subject
                                {
                                    Name = "NAGE WAZA",
                                    Quests = new List<Quest>
                                    {
                                        new Quest("En es", "Son las tecnicas de projeccion."),
                                        new Quest("O GOSHI", "Levantar pescando."),
                                        new Quest("KO UCHI GARI", "Pequeño barrido interior"),
                                    },
                                    Subjects = new List<Subject>
                                    {
                                        new Subject
                                        {
                                            Name = "ASHI WAZA",
                                            Quests = new List<Quest>
                                            {
                                                new Quest("En es", "Son las tecnicas que se ejecutan con las piernas."),
                                                new Quest("O UCHI GARI", "Barrido gran barrido interior"),
                                                new Quest("O SOTO GARI", "Barrido a la pierna adelantada"),
                                            }
                                        }
                                    }
                                },
                                new Subject
                                {
                                    Name = "NE WAZA",
                                    Quests = new List<Quest>
                                    {
                                        new Quest("En es", "Son las tecnicas que se ejecutan en el suelo"),
                                        new Quest("GATAME WAZA", "Inmobilizaciones en el suelo"),
                                        new Quest("HON KESA GATAME", "Inmobilizacion basica del triangulo superior"),
                                    }
                                }
                            }
                        }
                    }
                }
            };

        public Task<IEnumerable<ExamQuest>> GetExams() =>
            Task.FromResult(ExamQuests.AsEnumerable());

        public Task<IEnumerable<ExamQuest>> GetQuests(string code) =>
            Task.FromResult(ExamQuests.Where(c => c.Code == code));
    }
}