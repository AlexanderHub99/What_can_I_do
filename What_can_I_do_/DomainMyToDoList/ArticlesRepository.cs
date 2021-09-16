using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace What_can_I_do_.DomainMyToDoList
{
    public class ArticlesRepository
    {
        //класс-репозиторий напрямую обращается к контексту базы данных
        private readonly AppDbContext context;
        public ArticlesRepository(AppDbContext context)
        {
            this.context = context;
        }

        //выбрать все записи из таблицы Task
        public IQueryable<Task> GetArticles()
        {
            return context.Tasks.OrderBy(x => x.TTask);
        }

        //найти определенную запись по id
        public Task GetArticleById(Guid id)
        {
            return context.Tasks.Single(x => x.id == id);
        }

        //сохранить новую либо обновить существующую запись в БД
        public Guid SaveArticle(Task entity)
        {
            if (entity.id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.id;
        }

        //удалить существующую запись
        public void DeleteArticle(Task entity)
        {
            context.Tasks.Remove(entity);
            context.SaveChanges();
        }
    }
}
