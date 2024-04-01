namespace wsb_oop.Product.model;

public record ProductDto(
    Guid Id,
    string Name,
    string Description
);