# Generated by Django 2.2.5 on 2020-12-08 19:23

from django.db import migrations
import django.db.models.manager


class Migration(migrations.Migration):

    dependencies = [
        ('ChessApp', '0007_auto_20201203_1415'),
    ]

    operations = [
        migrations.AlterModelManagers(
            name='chessgamegroup',
            managers=[
                ('Groups', django.db.models.manager.Manager()),
            ],
        ),
    ]
