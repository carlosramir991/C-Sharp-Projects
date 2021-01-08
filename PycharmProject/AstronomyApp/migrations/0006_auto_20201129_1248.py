# Generated by Django 2.2.5 on 2020-11-29 17:48

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('AstronomyApp', '0005_auto_20201125_1424'),
    ]

    operations = [
        migrations.RenameField(
            model_name='planet',
            old_name='planet_identification',
            new_name='name',
        ),
        migrations.AlterField(
            model_name='planet',
            name='magnetic_field',
            field=models.BooleanField(default=False),
        ),
        migrations.AlterField(
            model_name='planet',
            name='water',
            field=models.BooleanField(default=False),
        ),
        migrations.CreateModel(
            name='Star',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=40)),
                ('planets', models.ManyToManyField(to='AstronomyApp.Planet')),
            ],
        ),
        migrations.CreateModel(
            name='Galaxy',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('name', models.CharField(max_length=40)),
                ('type', models.CharField(max_length=40)),
                ('distance', models.CharField(max_length=40)),
                ('stars', models.ManyToManyField(to='AstronomyApp.Star')),
            ],
        ),
    ]