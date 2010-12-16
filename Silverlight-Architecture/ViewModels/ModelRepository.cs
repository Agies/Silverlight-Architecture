using System;
using System.Collections.Generic;

namespace SilverlightArchitecture
{
    public class ModelRepository<TModel> : IModelRepository<TModel> where TModel : class, new()
    {
        public TModel Get()
        {
            if (typeof(TModel) == typeof(ExampleModel))
            {
                var model = new TModel();
                var employee = model as ExampleModel;
                employee.FirstName = "Jerel";
                employee.LastName = "Hass";
                employee.Projects = new List<Project>
                                        {
                                            new Project
                                                {
                                                    Name = "Avizent",
                                                    Website = new Uri("http://Avizentrisk.com")
                                                }
                                        };
                return model;
            }
            return default(TModel);
        }
    }
}