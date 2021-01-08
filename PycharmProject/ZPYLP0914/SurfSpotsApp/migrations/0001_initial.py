# Generated by Django 2.2.5 on 2020-10-29 22:00

from django.db import migrations, models


class Migration(migrations.Migration):

    initial = True

    dependencies = [
    ]

    operations = [
        migrations.CreateModel(
            name='SurfSpots',
            fields=[
                ('id', models.AutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('spotName', models.CharField(blank=True, default='', max_length=50, verbose_name='Surf Spot Name')),
                ('location', models.CharField(blank=True, default='', max_length=60, verbose_name='Location')),
                ('description', models.TextField(blank=True, default='', max_length=300, verbose_name='Your Description')),
                ('rating', models.CharField(choices=[('Weak', 'Weak'), ('Marginal', 'Marginal'), ('Good', 'Good'), ('Favorite', 'Favorite')], max_length=10, verbose_name='Your Rating')),
            ],
        ),
    ]
