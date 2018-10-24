namespace BookStore.DAL.Migrations
{
    using BookStore.DAL.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.DAL.EF.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.DAL.EF.BookContext context)
        {
            context.Books.AddOrUpdate(new Book { Id = 1, Name = "������� �������", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 1, CategoryId = 1, Price = 30});
            context.Books.AddOrUpdate(new Book { Id = 2, Name = "����� � ��������", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 1, CategoryId = 1 ,Price = 40});
            context.Books.AddOrUpdate(new Book { Id = 3, Name = "����� ����", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 2, CategoryId = 1,Price = 23});
            context.Books.AddOrUpdate(new Book { Id = 4, Name = "������� ����", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 3, CategoryId = 2,Price = 43});
            context.Books.AddOrUpdate(new Book { Id = 5, Name = "CLR via C#", Description = "� 1830 ���� ������ ��������� ������� ������. ������ � ������ ���� ��������� ��-�� ���������, � ��������� ��������� ������ �������� � ����������� �������������� � ������ ������� �������. ���������� ����� ����� � ������� ��� ����� ������������ ���������� ������ ��������. �� ��� ������ �� ������ ����� ���������� ������������, � ��� ����� � ������� �������. ����� ���������� ����������� �� �������� � ���� ��������: �������, ������, ���������, ����������� ���������� � ������� - ����������. ������� ��������� � ��������� �� �������, �������� ����� (��������-��������).", AuthorId = 3, CategoryId = 3, Price = 53});

            //End Books Initialize

            //Start Authors Initialize
            context.Authors.AddOrUpdate(new Author { Id = 1, Name = "�.�.������" });
            context.Authors.AddOrUpdate(new Author { Id = 2, Name = "�.�.���������" });
            context.Authors.AddOrUpdate(new Author { Id = 3, Name = "������ ����" });
            //End Authors Initialize

            //Start Categories Initialize
            context.Categories.AddOrUpdate(new Category { Id = 1, CategoryName = "��������" });
            context.Categories.AddOrUpdate(new Category { Id = 2, CategoryName = "�������" });
            context.Categories.AddOrUpdate(new Category { Id = 3, CategoryName = "�����" });
            context.Categories.AddOrUpdate(new Category { Id = 4, CategoryName = "������" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}