# Generated by Django 2.2.5 on 2020-12-02 19:23

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='ChessGame',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('url', models.CharField(max_length=120)),
                ('time_control', models.CharField(max_length=60)),
                ('end_time', models.IntegerField()),
                ('rated', models.BooleanField()),
                ('fen', models.CharField(max_length=120)),
                ('time_class', models.CharField(max_length=60)),
                ('rules', models.CharField(max_length=60)),
                ('white_player', models.CharField(max_length=60)),
                ('white_player_rating', models.CharField(max_length=10)),
                ('white_player_result', models.CharField(max_length=30)),
                ('black_player', models.CharField(max_length=60)),
                ('black_player_rating', models.CharField(max_length=10)),
                ('black_player_result', models.CharField(max_length=30)),
            ],
        ),
    ]
