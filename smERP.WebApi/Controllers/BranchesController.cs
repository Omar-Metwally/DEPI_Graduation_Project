﻿using Microsoft.AspNetCore.Mvc;
using smERP.Application.Features.Branches.Commands.Models;
using smERP.Application.Features.Branches.Queries.Models;
using smERP.Application.Features.StorageLocations.Commands.Models;

namespace smERP.WebApi.Controllers;

[Route("[controller]")]
[ApiController]
public class BranchesController : AppControllerBase
{
    [HttpGet("List")]
    public async Task<IActionResult> GetAllBranches()
    {
        var response = await Mediator.Send(new GetAllBranchesQuery());
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpGet("List-With-Storage-Locations")]
    public async Task<IActionResult> GetBranchesWithStorageLocations()
    {
        var response = await Mediator.Send(new GetBranchesWithStorageLocationsQuery());
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpGet]
    public async Task<IActionResult> GetPaginatedBranches([FromQuery] GetPaginatedBranchesQuery request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpGet("{branchId}")]
    public async Task<IActionResult> GetBranch(int branchId)
    {
        var response = await Mediator.Send(new GetBranchQuery(branchId));
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpPost]
    public async Task<IActionResult> CreateBranch([FromBody] AddBranchCommandModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateBranch([FromBody] EditBranchCommandModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteBranch([FromBody] DeleteBranchCommandModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpGet("{branchId}/storage-locations/{storageLocationId}")]
    public async Task<IActionResult> GetStorageLocation(int branchId, int storageLocationId)
    {
        var response = await Mediator.Send(new GetStorageLocationQuery(branchId, storageLocationId));
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpPost("{request.BranchId}/storage-locations")]
    public async Task<IActionResult> CreateStorageLocation([FromBody] AddStorageLocationCommandModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpPut("{request.BranchId}/storage-locations/{request.StorageLocationId}")]
    public async Task<IActionResult> UpdateStorageLocation([FromBody] EditStorageLocationCommandModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpDelete("{request.BranchId}/storage-locations/{request.StorageLocationId}")]
    public async Task<IActionResult> DeleteStorageLocation([FromBody] DeleteStorageLocationCommandModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }

    [HttpPost("{request.BranchId}/storage-location/{request.StorageLocationId}/procurement-transactions")]
    public async Task<IActionResult> CreateStoredProductInstances([FromBody] AddProductInstanceToStorageLocationModel request)
    {
        var response = await Mediator.Send(request);
        var apiResult = response.ToApiResult();
        return StatusCode(apiResult.StatusCode, apiResult);
    }
}