# Generated by Django 2.2.5 on 2020-11-11 04:47

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('MovieUpapp', '0002_auto_20201106_1629'),
    ]

    operations = [
        migrations.AlterField(
            model_name='movie',
            name='release_date',
            field=models.DateField(),
        ),
    ]
