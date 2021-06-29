﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaxService.Application.Repositories
{
    public interface IAsyncRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync(CancellationToken cancelationToken);
        Task<T> GetAsync(int id, CancellationToken cancelationToken);
        Task CreateAsync(T item, CancellationToken cancelationToken);
        Task UpdateAsync(T item, CancellationToken cancelationToken);
        Task DeleteAsync(int id, CancellationToken cancelationToken);
    }
}
