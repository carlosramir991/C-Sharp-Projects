# Generated by Django 2.2.5 on 2020-09-25 16:18

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('RealEstateApp', '0002_auto_20200925_1215'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='client',
            name='primary_bank',
        ),
    ]
