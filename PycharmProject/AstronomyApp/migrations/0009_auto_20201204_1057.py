# Generated by Django 2.2.5 on 2020-12-04 18:57

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('AstronomyApp', '0008_auto_20201201_2323'),
    ]

    operations = [
        migrations.AlterField(
            model_name='planet',
            name='name',
            field=models.CharField(max_length=50, verbose_name='Planet name'),
        ),
    ]
