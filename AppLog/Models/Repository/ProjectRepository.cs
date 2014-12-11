using System;

namespace AppLog.Models.Repository
{
    public class ProjectRepository : Repository
    {
        public static bool Create(Project project)
        {
            project.CreatedAt = DateTime.Now;
            project.OwnerId = Auth.GetUser().Id;
            project.ApiKey = Project.GenerateApiKey();

            db.Project.Add(project);

            return db.SaveChanges() > 0;
        }
    }
}