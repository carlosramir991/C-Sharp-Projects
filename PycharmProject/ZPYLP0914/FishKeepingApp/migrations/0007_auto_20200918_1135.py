# Generated by Django 2.2.5 on 2020-09-18 18:35

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('FishKeepingApp', '0006_auto_20200917_2159'),
    ]

    operations = [
        migrations.AlterField(
            model_name='fishwishlist',
            name='fish_type',
            field=models.CharField(choices=[('Freshwater', 'Freshwater'), ('Brackish', 'Brackish'), ('Saltwater', 'Saltwater')], max_length=10, null=True),
        ),
    ]
