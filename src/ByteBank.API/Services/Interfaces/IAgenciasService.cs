// <copyright file="IAgenciasService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using ByteBank.API.Request;
using ByteBank.API.ViewModels;

namespace ByteBank.API.Services.Interfaces
{
    public interface IAgenciasService
    {
        Task<bool> AlteraAgenciaAsync(AgenciaRequest agenciaRequest);

        Task<AgenciaViewModel?> BuscaAgenciaPorIdAsync(int id);

        Task<List<AgenciaViewModel>?> BuscaAgenciasAsync();

        Task<AgenciaViewModel> CriaAgenciaAsync(AgenciaRequest agenciaRequest);

        Task<bool> DeletaAgenciaAsync(int id);
    }
}