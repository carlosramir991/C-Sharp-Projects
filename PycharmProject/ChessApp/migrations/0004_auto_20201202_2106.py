# Generated by Django 2.2.5 on 2020-12-03 05:06

from django.db import migrations, models
import django.db.models.manager


class Migration(migrations.Migration):

    dependencies = [
        ('ChessApp', '0003_auto_20201202_1236'),
    ]

    operations = [
        migrations.AlterModelManagers(
            name='chessgame',
            managers=[
                ('Games', django.db.models.manager.Manager()),
            ],
        ),
        migrations.AlterModelManagers(
            name='chessgamegroup',
            managers=[
                ('Group', django.db.models.manager.Manager()),
            ],
        ),
        migrations.AddField(
            model_name='chessgamegroup',
            name='game_list1',
            field=models.CharField(max_length=255, null=True),
        ),
        migrations.AddField(
            model_name='chessgamegroup',
            name='game_list2',
            field=models.CharField(max_length=255, null=True),
        ),
        migrations.AddField(
            model_name='chessgamegroup',
            name='player1',
            field=models.CharField(default='foo', max_length=120),
            preserve_default=False,
        ),
        migrations.AddField(
            model_name='chessgamegroup',
            name='player2',
            field=models.CharField(default='foo', max_length=120),
            preserve_default=False,
        ),
    ]
