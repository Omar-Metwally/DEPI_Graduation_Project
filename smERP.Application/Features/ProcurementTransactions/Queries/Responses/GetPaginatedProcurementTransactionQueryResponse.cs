﻿using smERP.Application.Features.ProcurementTransactions.Commands.Models;

namespace smERP.Application.Features.ProcurementTransactions.Queries.Responses;

public record GetPaginatedProcurementTransactionQueryResponse(
    int TransactionId,
    string Supplier,
    string Branch,
    string StorageLocation,
    DateTime TransactionDate,
    IEnumerable<Payment> Payments,
    IEnumerable<TransactionItem> Products);

public record TransactionItem(int ProductInstanceId, string Name, int Quantity, decimal UnitPrice, IEnumerable<ProductUnit>? Units);

public record ProductUnit(string SerialNumber);