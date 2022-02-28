using Microsoft.AspNetCore.Mvc;
using POC.Config.DTOs;

namespace POC.Config.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
[ProducesErrorResponseType(typeof(void))]
public class StoreController : ControllerBase
{
    public StoreController()
    {
    }

    // TODO try and fit the mongodb save into the same repo pattern MCP has
    // TODO try and fit the mongodb save into the same repo pattern MCP has
    // TODO try and fit the mongodb save into the same repo pattern MCP has
    // TODO try and fit the mongodb save into the same repo pattern MCP has
    // TODO look at storing all store config(address, phone, config, feature flags) into mongodb
    // TODO look at storing all store config(address, phone, config, feature flags) into mongodb
    // TODO look at storing all store config(address, phone, config, feature flags) into mongodb
    // TODO look at storing all store config(address, phone, config, feature flags) into mongodb
    
    
    /// <summary>
    /// Create store
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Created store</returns>
    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<Store>> Post(
        CancellationToken cancellationToken)
    {
        // Map request
        
        // Mediatr send
        /// Validate
        /// Create store
        /// Create config
        ///

        // Map response

        var store = new Store();

        return CreatedAtAction(nameof(Get), new { id = store.Id }, store);
    }
    
    /// <summary>
    /// Get store
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Created store</returns>
    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Store>> Get(
        CancellationToken cancellationToken)
    {
        // Map request
        
        // Mediatr send
        
        // Map response

        var store = new Store();

        return Ok(store);
    }
    
    /// <summary>
    /// Create store
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Created store</returns>
    [HttpPost("")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<Store>> UpdateConfig(
        CancellationToken cancellationToken)
    {
        // Map request
        
        // Mediatr send
        
        // Map response

        var store = new Store();

        return CreatedAtAction(nameof(Get), new { id = store.Id }, store);
    }

    /// <summary>
    /// Get store
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns>Created store</returns>
    [HttpGet("{id:int}/Config")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Store>> GetConfig(
        CancellationToken cancellationToken)
    {
        // Map request
        
        // Mediatr send
        
        // Map response

        var store = new Store();

        return Ok(store);
    }
}