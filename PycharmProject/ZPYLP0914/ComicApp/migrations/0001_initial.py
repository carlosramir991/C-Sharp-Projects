# Generated by Django 2.2.5 on 2020-09-23 12:59

from django.db import migrations, models
import django.db.models.deletion
import django.db.models.manager


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='ComicUser',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('username', models.CharField(default='', max_length=255, unique=True)),
                ('email', models.EmailField(default='', max_length=255, unique=True)),
                ('birth_date', models.DateField(default='', verbose_name='Date of Birth')),
                ('password', models.CharField(default='', max_length=255)),
                ('created', models.DateTimeField(default='')),
                ('modified', models.DateTimeField(default='')),
            ],
            managers=[
                ('users', django.db.models.manager.Manager()),
            ],
        ),
        migrations.CreateModel(
            name='ComicReview',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('series', models.CharField(default='', max_length=255)),
                ('issue', models.CharField(default='', max_length=255)),
                ('rating', models.PositiveSmallIntegerField(choices=[(1, 1), (2, 2), (3, 3), (4, 4), (5, 5), (6, 6), (7, 7), (8, 8), (9, 9), (10, 10)])),
                ('review', models.TextField(default='')),
                ('created', models.DateTimeField(default='')),
                ('modified', models.DateTimeField(default='')),
                ('user', models.ForeignKey(on_delete=django.db.models.deletion.CASCADE, to='ComicApp.ComicUser')),
            ],
            managers=[
                ('reviews', django.db.models.manager.Manager()),
            ],
        ),
    ]