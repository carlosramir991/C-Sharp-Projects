from django.db import models

# limit choices for spirit and flavor profile
SPIRIT_CHOICES = [
    ('vodka','vodka'),
    ('whiskey','whiskey'),
    ('tequila','tequila'),
    ('gin','gin'),
    ('rum','rum'),
]

FLAVOR_PROFILE_CHOICES = [
    ('sweet','sweet'),
    ('sour','sour'),
    ('spicy','spicy'),
    ('bitter','bitter'),
    ('boozy','boozy'),

]

# Define models

# model to create a cocktail
class Cocktail(models.Model):
    name = models.CharField(max_length=60, default="")
    spirit = models.CharField(max_length=60, choices=SPIRIT_CHOICES)
    ingredients = models.CharField(max_length=300)
    flavor_profile = models.CharField(max_length=200, choices=FLAVOR_PROFILE_CHOICES)

    objects = models.Manager()

    def __str__(self):
        return self.name
