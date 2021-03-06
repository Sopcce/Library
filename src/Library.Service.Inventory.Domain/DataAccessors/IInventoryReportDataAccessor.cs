using Library.Service.Inventory.Domain.DTOs;
using Library.Service.Inventory.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Service.Inventory.Domain.DataAccessors
{
    public interface IInventoryReportDataAccessor
    {
        List<AvailableBookLookupModel> GetAvailableBooks();

        void AddBook(AddBookDTO dto);

        List<BookViewModel> GetBooks();

        BookDetailedModel GetBookById(Guid bookId);

        bool ExistISBN(string isbn, Guid? bookId = null);

        void UpdateBookName(Guid bookId, string bookName);

        void UpdateBookDescription(Guid bookId, string description);

        void UpdateBookISBN(Guid bookId, string isbn);

        void UpdateBookIssuedDate(Guid bookId, DateTime issuedDate);

        void UpdateBookInventoryStatus(Guid bookInventoryId, BookInventoryStatus status, string notes, DateTime occurredDate);

        void AddBookInventory(Guid bookId, Guid bookInventoryId, BookInventoryStatus status, string notes);

        void RemoveBookInventory(Guid bookInventoryId);

        List<BookInventoryHistoryViewModel> GetBookInventoryHistories(Guid bookInventoryId);

        void DeleteBook(Guid bookId);

        void Commit();

        Task CommitAsync();
    }
}