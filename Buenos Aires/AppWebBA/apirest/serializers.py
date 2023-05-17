from rest_framework import serializers
from core.models import StockProducto

class StockProductoSerializer(serializers.ModelSerializer):
    class Meta:
        model = StockProducto
        fields = [
            'idstock', 
            'idprod', 
            'nrofac', 
        ]