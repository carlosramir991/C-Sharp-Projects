# Generated by Django 2.2.5 on 2020-11-25 03:59

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('AstronomyApp', '0003_auto_20201123_2306'),
    ]

    operations = [
        migrations.AlterField(
            model_name='planet',
            name='gravity',
            field=models.DecimalField(decimal_places=1, max_digits=3),
        ),
    ]
