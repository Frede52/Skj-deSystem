﻿using Microsoft.AspNetCore.Mvc;
using ServerAPI.Repositories;

[ApiController]
[Route("api/[controller]")]
public class TaskController : ControllerBase
{
    private readonly TaskRepository _repository;

    public TaskController()
    {
        _repository = new TaskRepository();
    }
}