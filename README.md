### ShopProject

Partie 1 du projet : 
4 classes Customer, Product, Order et OrderItem

Classe Order
- 2 constructeurs
- 2 propriétés
OrderId
OrderDate

2 méthodes
public Order Retrieve(int orderId)
public bool Save()
public bool Validate() -> verifier OrderDate != null

Classe OrderItem
- 2 constructeurs
- 2 propriétés
OrderItemId
ProductId
PurchasePrice (nullable)
Quantity

2 méthodes
public OrderItem Retrieve(int orderItemId)
public bool Save()
public bool Validate() -> verifier Quantity >= 0, ProductId >= 0 et PurchasePrice != null




