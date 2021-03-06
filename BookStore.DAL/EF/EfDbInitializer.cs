﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStore.DAL.Entities;
using BookStore.DAL.Repositories;

namespace BookStore.DAL.EF
{
    public class EfDbInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            //Start Books Initialize
            context.Books.Add(new Book { Id = 1, Name = "Повести Белкина", Description = "В 1830 году Россию захватила вспышка холеры. Дорога к Москве была перекрыта из-за карантина, и Александр Сергеевич Пушкин оказался в вынужденном затворничестве в имении Большое Болдино. Болдинская осень войдёт в историю как самый продуктивный творческий период писателя. За три месяца он создал около пятидесяти произведений, в том числе и Повести Белкина. Книгу составляют предисловие От издателя и пять повестей: Выстрел, Метель, Гробовщик, Станционный смотритель и Барышня - крестьянка. Издание выполнено с тиснением на обложке, содержит ляссе (ленточку-закладку).", AuthorId = 1, CategoryId = 1 });
            context.Books.Add(new Book { Id = 2, Name = "Повести Белкина", Description = "В 1830 году Россию захватила вспышка холеры. Дорога к Москве была перекрыта из-за карантина, и Александр Сергеевич Пушкин оказался в вынужденном затворничестве в имении Большое Болдино. Болдинская осень войдёт в историю как самый продуктивный творческий период писателя. За три месяца он создал около пятидесяти произведений, в том числе и Повести Белкина. Книгу составляют предисловие От издателя и пять повестей: Выстрел, Метель, Гробовщик, Станционный смотритель и Барышня - крестьянка. Издание выполнено с тиснением на обложке, содержит ляссе (ленточку-закладку).", AuthorId = 1, CategoryId = 1 });
            context.Books.Add(new Book { Id = 3, Name = "Повести Белкина", Description = "В 1830 году Россию захватила вспышка холеры. Дорога к Москве была перекрыта из-за карантина, и Александр Сергеевич Пушкин оказался в вынужденном затворничестве в имении Большое Болдино. Болдинская осень войдёт в историю как самый продуктивный творческий период писателя. За три месяца он создал около пятидесяти произведений, в том числе и Повести Белкина. Книгу составляют предисловие От издателя и пять повестей: Выстрел, Метель, Гробовщик, Станционный смотритель и Барышня - крестьянка. Издание выполнено с тиснением на обложке, содержит ляссе (ленточку-закладку).", AuthorId = 2, CategoryId = 1 });
            context.Books.Add(new Book { Id = 4, Name = "Повести Белкина", Description = "В 1830 году Россию захватила вспышка холеры. Дорога к Москве была перекрыта из-за карантина, и Александр Сергеевич Пушкин оказался в вынужденном затворничестве в имении Большое Болдино. Болдинская осень войдёт в историю как самый продуктивный творческий период писателя. За три месяца он создал около пятидесяти произведений, в том числе и Повести Белкина. Книгу составляют предисловие От издателя и пять повестей: Выстрел, Метель, Гробовщик, Станционный смотритель и Барышня - крестьянка. Издание выполнено с тиснением на обложке, содержит ляссе (ленточку-закладку).", AuthorId = 3, CategoryId = 2 });
            context.Books.Add(new Book { Id = 5, Name = "Повести Белкина", Description = "В 1830 году Россию захватила вспышка холеры. Дорога к Москве была перекрыта из-за карантина, и Александр Сергеевич Пушкин оказался в вынужденном затворничестве в имении Большое Болдино. Болдинская осень войдёт в историю как самый продуктивный творческий период писателя. За три месяца он создал около пятидесяти произведений, в том числе и Повести Белкина. Книгу составляют предисловие От издателя и пять повестей: Выстрел, Метель, Гробовщик, Станционный смотритель и Барышня - крестьянка. Издание выполнено с тиснением на обложке, содержит ляссе (ленточку-закладку).", AuthorId = 3, CategoryId = 3 });

            //End Books Initialize

            //Start Authors Initialize
            context.Authors.Add(new Author { Id = 1, Name = "А.С.Пушкин" });
            context.Authors.Add(new Author { Id = 2, Name = "М.С.Тургениев" });
            context.Authors.Add(new Author { Id = 3, Name = "Стивен Кинг" });
            //End Authors Initialize

            //Start Categories Initialize
            context.Genres.Add(new Genre { Id = 1, CategoryName = "Классика" });
            context.Genres.Add(new Genre { Id = 2, CategoryName = "Фентези" });
            context.Genres.Add(new Genre { Id = 3, CategoryName = "Ужасы" });
            context.Genres.Add(new Genre { Id = 4, CategoryName = "Драмма"});

            //End Categories Initialize

            base.Seed(context);
        }
    }
}
